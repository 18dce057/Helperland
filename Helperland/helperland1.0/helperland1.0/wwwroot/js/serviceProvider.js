﻿
                        unblock = "";

                    }
                }

});
                    }
                    }
                }
                    + '<p>' + result[i].serviceRequestId+'</p>'
                    + '<p>' + result[i].customerName+'</p></div><div class="col-5">'
                    + '<p> <span><img src="/image/calendar2.png" alt=""></span> <span class="upcoming-date"><b>' + result[i].serviceDate + '</b></span></p>'
                    + ' <p><span><img src="/image/layer-14.png" alt=""></span><span>' + result[i].startTime + ' - ' + result[i].endTime + '</span></p></div>'
                    + '<div class="col-4"><p>Rating</p>'
                    + '<div class="star-ratingmodel text-start">' + star + '</div></div></div><hr />'
                    + '<div class="row"><p><b>Customer Comments</b></p><p>' + result[i].comments + '</p></div></div>'




            }
var calendar;

function addServiceSchedule() {

    $.ajax({
        type: 'GET',
        url: "/ServiceProvider/GetServiceSchedule",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",

        success: function (result) {
            console.log(result);
            var events = [];
            if (result != "false") {

                for (let i = 0; i < result.length; i++) {
                    var bgColor = "#555";
                    if (result[i].status == 2) {
                        bgColor = "#146371";
                    }

                    console.log("result" + i + " : " + result[i].serviceRequestId);
                    events.push({
                        id: result[i].serviceRequestId,
                        start: result[i].date,
                        title: result[i].startTime + "-" + result[i].endTime,
                        backgroundColor: bgColor,
                        borderColor: "#fff",
                    });
                }

                console.log(events);

                calendar = new FullCalendar.Calendar(calendarEl, {
                    initialView: 'dayGridMonth',
                    headerToolbar: {
                        left: 'prev,next title',
                        center: '',
                        right: ''
                    },
                    events: events,
                    eventClick: function (info) {

                        console.log(info.event.id);
                        serviceRequestId = info.event.id;
                        $("#spserviceReqdetailsbtn").click();
                    },
                });
                calendar.render();
            }
            else {
                alert("something went wrong!");
            }
        },
        error: function (error) {
            alert(error);
        },

        beforeSend: function () {
            $("#loadingAnimation").removeClass("d-none");

        },

        complete: function () {
            setTimeout(function () {
                $("#loadingAnimation").addClass("d-none");
            }, 500);
        },
    });
}