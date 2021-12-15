/*for home page sticky header*/ 
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

//privacy policy remove button
function removeFun() {
	document.getElementById("privacy").style.display = "none";
}

//accordion (section) display - for customer or for service provider
$(document).ready(function () {
    $("#accordionExample2").css({ "display": "none" })
    $("#accordionExample").css({ "display": "block" })

    $("#label1").click(function () {
        $(this).css({"background-color": "#1d7a8c", "color" : "white"});
        $("#label2").css({"background-color": "#f6f6f6", "color": "#666666"});
        $("#accordionExample2").css({ "display": "none"});
        $("#accordionExample").css({ "display": "block" });
    })

    $("#label2").click(function () {
        $(this).css({"background-color": "#1d7a8c", "color" : "white", "cursor": "pointer"});
        $("#label1").css({"background-color": "#f6f6f6", "color": "#666666", "cursor": "pointer"});
        $("#accordionExample").css({ "display": "none" })
        $("#accordionExample2").css({ "display": "block" })
    })
})
