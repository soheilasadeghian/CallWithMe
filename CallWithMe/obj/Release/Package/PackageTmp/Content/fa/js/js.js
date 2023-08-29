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
            $("#error-text").html(result.message);
           
        }
        else {
            $("#success").addClass("show").removeClass("hidden");
            $("#error").removeClass("show").addClass("hidden");

        }
      
        return false;
    });
});