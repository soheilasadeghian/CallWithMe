$(function () {

    $("#submit").click(function (e) {
        e.preventDefault();
        var text = $("#text").val();
        var email = $("#email").val();
        var subject = $("#subject").val();

        var result = index.f1( email, subject, text);

        if (result.code == 1) {
            $("#error").addClass("show").removeClass("hidden");
            $("#success").removeClass("show").addClass("hidden");
            $("#error-text").html("input is not valid");
           
        }
        else if (result.code == 2) {
            $("#error").addClass("show").removeClass("hidden");
            $("#success").removeClass("show").addClass("hidden");
            $("#error-text").html("You can send message in 2 minutes.");

        }
        else {
            $("#success").addClass("show").removeClass("hidden");
            $("#error").removeClass("show").addClass("hidden");

        }
      
        return false;
    });
});