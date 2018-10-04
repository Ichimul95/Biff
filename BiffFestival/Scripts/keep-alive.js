$(document).ready(function () {
    var keepAlive = {
        refresh: function () {
            $.ajax({
                url: '/KeepAlive/Index',
                type: 'Get',
                success: function () {
                    setTimeout(keepAlive.refresh, 1000000);
                },
                error: function () {
                    setTimeout(keepAlive.refresh, 1000000);
                }
            });
        }
    };
});