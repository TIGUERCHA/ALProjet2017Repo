//$(document).ready();

//var dateFormat = "mm/dd/yy";
$('#calendar').datepicker({
    dateFormat: 'dd/mm/yy',
    inline: true,
    firstDay: 1,
    showOtherMonths: true,
    dayNamesMin: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],
    onSelect: function (dateText, inst) {
        $('#date-value').val(dateText);
        console.log(inst);
    }

});