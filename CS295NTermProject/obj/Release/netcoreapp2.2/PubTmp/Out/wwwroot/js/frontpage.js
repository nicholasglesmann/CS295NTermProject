$(document).ready(function () {
    // Transition effect for navbar 
    $('.navbar').removeClass('bg-dark');
    $('.navbar').removeClass('box-shadow');
    $('#logo').attr('src', '/files/images/smmlogoempty.svg');
    $(window).scroll(function () {
        // checks if window is scrolled more than 700px, adds/removes solid class
        if ($(this).scrollTop() > 640) {
            $('#logo').attr('src', '/files/images/smmlogo.svg');
            $('.navbar').addClass('bg-dark');
            $('.navbar').addClass('box-shadow');
        } else {
            $('#logo').attr('src', '/files/images/smmlogoempty.svg');
            $('.navbar').removeClass('bg-dark');
            $('.navbar').removeClass('box-shadow');
        }
    });
});
