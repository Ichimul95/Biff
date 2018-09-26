var clock;

$(document).ready(function () {
    var date = new Date(2018, 9, 14);
    var now = new Date();

    var clock = $('.clock').FlipClock(date, {
        clockFace: 'DailyCounter',
        countdown: true
    });

});