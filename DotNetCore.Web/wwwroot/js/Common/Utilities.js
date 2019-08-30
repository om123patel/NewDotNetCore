/// <reference path="../../lib/bootstrap-toastr/toastr.js" />


//Show loader when ajax call starts and hide it when ajax call stops
var isShowAjaxLoader = false;

function AjaxLoader() {
    var dialog;
    this.Start = function (displayText) {
        App.blockUI({
            boxed: true
        });
    };
    this.Stop = function () {
        App.unblockUI();
    };
}

$(document).ajaxStart(function () {
    if (isShowAjaxLoader) {
        var loader = new AjaxLoader();
        loader.Start();
    }
});

$(document).ajaxStop(function () {
    isShowAjaxLoader = false;
    var loader = new AjaxLoader();
    loader.Stop();
});

function PostToServer(options) {
    var defaults = {
        'url': null,
        'data': null,
        'async': true,
        'onSuccess': null,
        'onError': null,
        'showLoader': true,
        'traditional': true,
    };
    
    var parameters = $.extend(defaults, options);
    var loader = new AjaxLoader();

    if (parameters.data !== null) {
        parameters.data = TrimData(parameters.data);
    }
    isShowAjaxLoader = parameters.showLoader;
    
    $.ajax(
        {
            url: parameters.url,
            type: "POST",
            async: parameters.async,
            data: JSON.stringify(parameters.data),
            contentType: "application/json",
            //beforeSend: function (xhr) {
            //    xhr.setRequestHeader("XSRF-TOKEN",
            //        $('input:hidden[name="__RequestVerificationToken"]').val());
            //},
            success: function (res) {

                if (res !== null && res.code === '401') {
                    window.location = res.returnUrl;
                    return false;
                }
                if ($.isFunction(parameters.onSuccess)) {
                    parameters.onSuccess(res);
                }
            },
            error: function (xhr, status, error) {
                if ($.isFunction(parameters.onError)) {
                    parameters.onError(xhr, status, error);
                }
            }
        });
}

function GetFromServer(options) {

    var defaults = {
        'url': null,
        'data': null,
        'onSuccess': null,
        'onError': null
    };

    var parameters = $.extend(defaults, options);
    var loader = new AjaxLoader();

    if (parameters.data !== null) {
        parameters.data = TrimData(parameters.data);
    }

    $.ajax(
        {
            url: parameters.url,
            type: "GET",
            cache: false,
            data: JSON.stringify(parameters.data),
            contentType: "application/json",
            beforeSend: function () {
                loader.Start();
            },
            complete: function () {
                loader.Stop();
            },
            success: function (res) {
                if (res !== null && res.code === '401') {
                    window.location = res.returnUrl;
                    return false;
                }
                if ($.isFunction(parameters.onSuccess)) {
                    parameters.onSuccess(res);
                }
            },
            error: function (xhr, status, error) {
                if ($.isFunction(parameters.onError)) {
                    parameters.onError(xhr, status, error);
                }
            }
        });
}

function TrimData(data) {
    $.each(data, function (key, val) {
        if (val === null || val === undefined) {
            return null;
        }
        else {
            if (typeof (val) === "object") {
                TrimData(val);
            }
            else {
                data[key] = $.trim(val);
            }
        }
    });
    return data;
}

function Message() {
    var options = {
        showDuration: 500,
        onShown: undefined,
        onHidden: undefined,
        extendedTimeOut: 1000,
        iconClass: 'toast-info',
        positionClass: 'toast-top-center',
        timeOut: 5000, // Set timeOut and extendedTimeOut to 0 to make it sticky
        newestOnTop: true,
        preventDuplicates: false,
        progressBar: false,
        closeButton: true
    };
    var toastElement;
    var toastType = {
        Error: 'toast-error',
        Info: 'toast-info',
        Success: 'toast-success',
        Warning: 'toast-warning'
    };
    Message.prototype.Type = toastType;
    Message.prototype.Show = function (message, title, type, sticky, position, onShow, onHide) {
        if (sticky !== undefined && typeof sticky === "boolean" && sticky == true) {
            options.extendedTimeOut = 0;
            options.timeOut = 0;
        }
        if (position !== undefined && typeof position === "string") {
            options.positionClass = position;
        }
        if (onShow !== undefined && $.isFunction(onShow)) {
            options.onShown = onShow;
        }
        if (onHide !== undefined && $.isFunction(onHide)) {
            options.onHidden = onHide;
        }
        toastr.options = options;

        switch (type) {
            case toastType.Error:
                toastElement = toastr.error(message, title);
                break;
            case toastType.Info:
                toastElement = toastr.info(message, title);
                break;
            case toastType.Success:
                toastElement = toastr.success(message, title);
                break;
            case toastType.Warning:
                toastElement = toastr.warning(message, title);
                break;
        }
    };

    Message.prototype.Clear = function () {
        if (toastElement !== undefined) {
            toastr.clear(toastElement);
        }
        else {
            toastr.clear();
        }
    };
}
Message.Position = {
    TopRight: 'toast-top-right',
    BottomRight: 'toast-bottom-right',
    BottomLeft: 'toast-bottom-left',
    TopLeft: 'toast-top-left',
    TopFullWidth: 'toast-top-full-width',
    BottomFullWidth: 'toast-bottom-full-width',
    TopCenter: 'toast-top-center',
    BottomCenter: 'toast-bottom-center'
};

/*
message : Message Body (string),
title : Message Title (string),
sticky : Whether to hide message automatically or not. (boolean),
position : Where to position the message. (Message.Position),
onShow : function to call when message is shown,
onHide : function to call after message is hidden,
*/
Message.Error = function (message, title, sticky, position, onShow, onHide) {
    if (message !== null && message !== '' && message !== undefined) {
        var messenger = new Message();
        messenger.Show(message, title, messenger.Type.Error, sticky, position, onShow, onHide);
        return messenger;
    }
};
/*
message : Message Body (string),
title : Message Title (string),
sticky : Whether to hide message automatically or not. (boolean),
position : Where to position the message. (Message.Position),
onShow : function to call when message is shown,
onHide : function to call after message is hidden,
*/
Message.Info = function (message, title, sticky, position, onShow, onHide) {
    var messenger = new Message();
    messenger.Show(message, title, messenger.Type.Info, sticky, position, onShow, onHide);
    return messenger;
};
/*
message : Message Body (string),
title : Message Title (string),
sticky : Whether to hide message automatically or not. (boolean),
position : Where to position the message. (Message.Position),
onShow : function to call when message is shown,
onHide : function to call after message is hidden,
*/
Message.Success = function (message, title, sticky, position, onShow, onHide) {
    var messenger = new Message();
    messenger.Show(message, title, messenger.Type.Success, sticky, position, onShow, onHide);
    return messenger;
};
/*
message : Message Body (string),
title : Message Title (string),
sticky : Whether to hide message automatically or not. (boolean),
position : Where to position the message. (Message.Position),
onShow : function to call when message is shown,
onHide : function to call after message is hidden,
*/
Message.Warning = function (message, title, sticky, position, onShow, onHide) {
    var messenger = new Message();
    messenger.Show(message, title, messenger.Type.Warning, sticky, position, onShow, onHide);
    return messenger;
};
Message.ClearAll = function () {
    var messenger = new Message();
    messenger.Clear();
};
Message.Clear = function (messageObj) {
    if (messageObj !== undefined && typeof messageObj === 'object' && messageObj instanceof Message) {
        messageObj.Clear();
    }
};