//var dateFormat = "mm/dd/yy";
$('#calendar').datepicker({
    dateFormat: 'dd/mm/yy',
    inline: true,
    firstDay: 1,
    showOtherMonths: true,
    dayNamesMin: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],
    onSelect: function (dateText, inst) {
        $('#form').val(dateText);
        alert("date recuperer : " + dateText);
    }

});

$('#timepicker').datepicker();