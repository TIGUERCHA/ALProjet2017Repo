$(document).ready(function () {
    $('input.timepicker').timepicker({});
});

$('#calendar').datepicker({
    dateFormat: 'dd/mm/yy',
    inline: true,
    firstDay: 1,
    showOtherMonths: true,
    dayNamesMin: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],
    onSelect: function (dateText, inst) {
        $('#form').val(dateText);
        alert("date recuperer : " + dateText);
        //faireTraitement(dateText);

    }

})

$('#timepicker').timepicker({
    timeFormat: 'h:mm p',
    interval: 60,
    minTime: '10',
    maxTime: '6:00pm',
    defaultTime: '11',
    startTime: '10:00',
    dynamic: false,
    dropdown: true,
    scrollbar: true
});

//$('#articlebtn').click(function () {

//    $('#codearticle').val($('#hiddencdecodearticle').val());
//    boost.popup.searchByarticle();

//});

//function searchByarticle() {

//    var codeArticle = escape($('#codearticle').val());
//    var libelleArticle = escape($('#libellearticle').val());
//    var horsNormeArticle = $("#libellehorsnorme").is(':checked');
//    this.initJqGridArticle();
//    $("#articlegrid").jqGrid('setGridParam', { url: urlGetArticleSearch + "?articlecode=" + codeArticle + "&articlelibelle=" + libelleArticle + "&horsnormearticle=" + horsNormeArticle, page: 1 }).trigger("reloadGrid");
//};
