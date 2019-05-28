// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.



/*login*/
$(document).ready(function () {
    var signUp = $('.signup-but');
    var logIn = $('.login-but');

    signUp.on('click', function () {
        $('.login').fadeOut('slow').css('display', 'none');
        $('.sign-up').fadeIn('slow');

        $('.form-container').animate({ left: '1vw' }, 'slow');
    });

    logIn.on('click', function () {
        $('.login').removeClass("hide");
        $('.sign-up').fadeOut('slow').css('display', 'none');
        $('.login').fadeIn('slow');
        

        $('.form-container').animate({ left: '28vw' }, 'slow');
    });
});



