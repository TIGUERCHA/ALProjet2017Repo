$(document).ready(function () {

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

$('#enregistrerId').click(function () {

    alert("a implimenter");
});

//function searchByarticle() {

//    var codeArticle = escape($('#codearticle').val());
//    var libelleArticle = escape($('#libellearticle').val());
//    var horsNormeArticle = $("#libellehorsnorme").is(':checked');
//    this.initJqGridArticle();
//    $("#articlegrid").jqGrid('setGridParam', { url: urlGetArticleSearch + "?articlecode=" + codeArticle + "&articlelibelle=" + libelleArticle + "&horsnormearticle=" + horsNormeArticle, page: 1 }).trigger("reloadGrid");
//};


$('#searchvalid').click(function () {
    alert("oui");
    ////var inputSearch = GetValueSearch();
    ////var url = saveSearchUrl + inputName + "&commandenum=" + inputSearch;
    //var inputName = $('#searchlibelle').val();
    //var defaut = $('#idDefaut').is(":checked");
    //var url = saveSearchUrl + inputName + "&defaut=" + defaut;
    //$.get(url, function (data) {
    //    $('#SearchSave').modal('hide');
    //    $('#idRechercheList').html(data);
    //});
});