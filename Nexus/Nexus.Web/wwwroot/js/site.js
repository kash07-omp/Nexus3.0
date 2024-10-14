// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/* -------------- NX DIALOGS --------------- */
function nxDialogsClass() {
    var me = this;
    var dialogList = [];
    var dlgBg = null;

    // Función auxiliar para verificar si un elemento es visible
    function isElementVisible(elem) {
        return !!(elem.offsetWidth || elem.offsetHeight || elem.getClientRects().length);
    }

    me.isDialogActive = function () {
        return dlgBg != null && isElementVisible(dlgBg);
    };

    //#region Funciones por defecto
    me.showDialog = function (id, title) {
        me.createMask();

        if (!document.querySelector('#' + id + '.initialized')) {
            me.buildDialog(id, title, false);
        } else {
            var currentContent = document.getElementById(id);
            currentContent.style.display = '';
            var dlgView = currentContent.closest('div.dlg-view');
            if (dlgView) {
                dlgView.classList.add('current');
                dlgView.style.display = '';
            }
        }

        dlgBg.style.display = '';
        // document.body.style.overflow = 'hidden';
        // document.body.style.paddingRight = '17px';
    };

    me.ajaxDialog = function (id, url, params, onLoad, onError) {
        me.createMask();
        me.loading();
        dlgBg.style.display = '';
        // document.body.style.overflow = 'hidden';
        // document.body.style.paddingRight = '17px';

        var paramsJson = JSON.stringify(params);
        fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: paramsJson
        })
            .then(function (response) {
                return response.text();
            })
            .then(function (data) {
                if (data) {
                    var newContent = document.createElement('div');
                    newContent.id = id;
                    newContent.innerHTML = data;
                    document.body.appendChild(newContent);

                    if (typeof onLoad !== 'undefined')
                        onLoad(newContent);

                    me.buildDialog(id, 'test', true);
                    me.loaded();
                } else {
                    me.popDialog();
                    if (typeof onError !== 'undefined')
                        onError(data.error);
                }
            })
            .catch(function (error) {
                me.popDialog();
                console.error('Error al cargar el diálogo:', error);
                if (typeof onError !== 'undefined')
                    onError(error);
            });
    };

    me.loading = function () {
        if (dlgBg != null) {
            dlgBg.classList.add('loading');
        }
    };

    me.loaded = function () {
        if (dlgBg != null) {
            dlgBg.classList.remove('loading');
        }
    };

    me.createMask = function () {
        if (dlgBg == null) {
            dlgBg = document.createElement('div');
            dlgBg.id = 'dlgmask';
            document.body.appendChild(dlgBg);

            dlgBg.addEventListener('click', function (e) {
                e.stopPropagation();
                me.popDialog();
            });

            window.addEventListener('keyup', function (event) {
                if (event.keyCode === 27) { // Esc
                    me.popDialog();
                }
            });
        }
    };

    me.buildDialog = function (id, title, ajax) {
        var dlgView = document.createElement('div');
        dlgView.className = 'dlg-view current cybercard ' + id;
        dlgView.style.opacity = '0';
        document.getElementById('dlgmask').appendChild(dlgView);

        dlgView.addEventListener('click', function (e) {
            e.stopPropagation();
        });

        if (ajax)
            dlgView.classList.add('ajax');

        //var closeButton = document.createElement('button');
        //closeButton.className = 'close';
        //closeButton.innerHTML = '<i class="material-icons-outlined">close</i>';
        //closeButton.addEventListener('click', function (e) {
        //    e.preventDefault();
        //    me.popDialog();
        //});

        //var header = document.createElement('div');
        //header.className = 'dlg-header';
        //header.appendChild(closeButton);

        //var spanTitle = document.createElement('span');
        //spanTitle.textContent = title;
        //header.appendChild(spanTitle);

        //dlgView.appendChild(header);

        var content = document.getElementById(id);
        if (content) {
            content.parentNode.removeChild(content); // Detach
        }

        // Vincular eventos a botones con clase 'cancel'
        var cancelButtons = content.querySelectorAll('button.cancel');
        cancelButtons.forEach(function (button) {
            button.addEventListener('click', function (e) {
                e.preventDefault();
                me.popDialog();
            });
        });

        content.classList.add('initialized', 'dlg-content');

        dlgView.appendChild(content);
        content.style.display = '';

        // Posicionar y mostrar el diálogo
        setTimeout(function () {
            var marginTop = Math.max(50, (window.innerHeight - dlgView.offsetHeight) / 2) + 'px';
            dlgView.style.marginTop = marginTop;
            dlgView.style.opacity = '1';
        }, 10);
    };

    me.popDialog = function () {
        if (dlgBg != null) {
            dlgBg.style.display = 'none';
        }
        document.body.style.overflow = 'auto';
        document.body.style.paddingRight = '0';

        var currentDialog = dlgBg.querySelector('div.dlg-view.current');
        if (currentDialog) {
            currentDialog.classList.remove('current');
            currentDialog.style.display = 'none';
            if (currentDialog.classList.contains('ajax'))
                currentDialog.parentNode.removeChild(currentDialog);
        }
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


