// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/* -------------- NX DIALOGS --------------- */
function nxDialogsClass() {
	var me = this;
	var dialogList = [];
	var dlgBg = null;

	me.isDialogActive = function () {
		return dlgBg != null && dlgBg.is(":visible");
	}

	//#region Default functions
	me.showDialog = function (id, title) {
		me.createMask();

		if (!$('#' + id + '.initialized').exists()) {
			me.buildDialog(id, title, false);
		}
		else {
			var currentContent = $('#' + id);
			currentContent.show();
			currentContent.closest('div.dlg-view').addClass('current').show();
		}

		dlgBg.show();
		//$('body').css('overflow', 'hidden').css('padding-right', '17px');
	};

	me.ajaxDialog = function (id, url, params, onLoad, onError) {
		me.createMask();
		me.loading();
		dlgBg.show();
		//$('body').css('overflow', 'hidden').css('padding-right', '17px');

		var paramsJson = JSON.stringify(params);
		$.ajax({
			type: "POST",
			url: url,
			data: paramsJson,
			contentType: "application/json",
		}).done(function (data, textStatus) {
			if (data) {
				var newContent = jQuery('<div/>', {
					id: id
				}).html(data).appendTo('body');
				if (typeof (onLoad) != 'undefined')
					onLoad(newContent);
				me.buildDialog(id, 'test', true);
				me.loaded();
			}
			else {
				me.popDialog();
				if (typeof (onError) != 'undefined')
					onError(data.error);
			}
		}).fail(function () {
			me.popDialog();
			//TODO: Show error
		}).always(function (XMLHttpRequest, textStatus) {
		});
	};

	me.loading = function () {
		if (dlgBg != null) {
			dlgBg.addClass('loading');
		}
	};

	me.loaded = function () {
		if (dlgBg != null) {
			dlgBg.removeClass('loading');
		}
	};

	me.createMask = function () {
		if (dlgBg == null) {
			dlgBg = jQuery('<div/>', {
				id: 'dlgmask'
			}).appendTo('body');
			dlgBg.on('click', function (e) {
				e.stopPropagation();
				me.popDialog();
			});
			$(window).keyup(function (event) {
				if (event.keyCode == 27) { //esc
					me.popDialog();
				}
			});
		}
	};

	me.buildDialog = function (id, title, ajax) {
		var dlgView = jQuery('<div/>', {
			'class': 'dlg-view current cybercard ' + id,
			'style': 'opacity:0;'
		}).appendTo('#dlgmask');
		dlgView.on('click', function (e) {
			e.stopPropagation();
		});
		if (ajax)
			dlgView.addClass('ajax');
		var closeButton = jQuery('<button/>', {
			'class': 'close'
		}).append('<i class="material-icons-outlined">close</i>').on('click', function (e) {
			e.preventDefault();
			me.popDialog();
		});
		var header = jQuery('<div/>', {
			'class': 'dlg-header'
		}).append(closeButton).append('<span>' + title + '</span>');
		var contentWrapper = jQuery('<div/>', {
			'class': 'dlg-content'
		});
		var content = $('#' + id).detach();
		content.find('button.cancel').on('click', function (e) {
			e.preventDefault();
			me.popDialog();
		});
		content.addClass('initialized dlg-content');
		//contentWrapper.append(content);
		dlgView.append(content);
		content.show();
		//dlgView.append(contentWrapper);
		setTimeout(function () {
			dlgView.css("margin-top", Math.max(50, ($(window).height() - dlgView.outerHeight()) / 2) + "px");
			dlgView.css('opacity', 1);
		}, 10);

	};

	me.popDialog = function () {
		dlgBg.hide();
		$('body').css('overflow', 'auto').css('padding-right', '0');
		var currentDialog = dlgBg.find('div.dlg-view.current');
		currentDialog.removeClass('current');
		currentDialog.hide();
		if (currentDialog.hasClass('ajax'))
			currentDialog.remove();
	};
}
var nxDialogs = new nxDialogsClass();

/* -------------- NX UTILS --------------- */

// Convert the date string from DateTime to a format JavaScript understands (YYYY-MM-DDTHH:mm:ssZ)
function convertToJsDate(sourceUtcDate) {
	console.log('sourceUtcDate: ' + sourceUtcDate);

	// Dividir componentes de fecha y hora
	const [date, time] = sourceUtcDate.split(' ');
	const [day, month, year] = date.split('/');
	const [hours, minutes, seconds] = time.split(':');

	// Crear una marca de tiempo en UTC
	const utcTimestamp = Date.UTC(year, month - 1, day, hours, minutes, seconds);

	// Crear un objeto Date usando la marca de tiempo UTC
	const utcDate = new Date(utcTimestamp);

	return utcDate;
}


