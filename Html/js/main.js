$(document).ready(function () {
    var scroll_start = 0;
    var startchange = $('#navbar-home-page');
    var offset = startchange.offset();
    $(document).scroll(function () {
        scroll_start = $(this).scrollTop();
        if (scroll_start > offset.top) {
            $('#nav').css({ "background-color": "rgba(82, 82, 82, 0.9)" });
            $('#navlogo').css({ "height": "54px", "width": "73px" })
        } else {
            $('#nav').css('background-color', 'transparent');
            $('#navlogo').css({ "height": "130px", "width": "175px" });
        }
    });
});


function removeFun() {
	document.getElementById("privacy").style.display = "none";
}
