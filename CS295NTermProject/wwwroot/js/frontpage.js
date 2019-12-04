$(document).ready(function () {
    // Transition effect for navbar 
    $('#small-logo').addClass('d-none');
    $('.navbar').removeClass('bg-dark');
    $('.navbar').removeClass('box-shadow');
    $(window).scroll(function () {
        // checks if window is scrolled more than 700px, adds/removes solid class
        if ($(this).scrollTop() > 640) {
            $('#small-logo').removeClass('d-none');
            $('.navbar').addClass('bg-dark');
            $('.navbar').addClass('box-shadow');
        } else {
            $('#small-logo').addClass('d-none');
            $('.navbar').removeClass('bg-dark');
            $('.navbar').removeClass('box-shadow');
        }
    });
});
