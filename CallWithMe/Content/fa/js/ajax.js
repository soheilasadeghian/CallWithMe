var index = {

    urls: [
             "sendMail",
    ],

    f1: function ( to, subject, text) {
        var result;
        var token = $('[name=__RequestVerificationToken]').val();
        var headers = {};
        headers["__RequestVerificationToken"] = token;

        $.ajax({
            type: "POST",
            url: index.urls[0],
            headers:headers,
            data: JSON.stringify({ to: to, subject: subject, text: text } ),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            async: false,
            success: function (response) {

                result = response;

            },
            failure: function (response) {

                result = "error";
            }
        });

        return result;
    }
}