var dateSelected = null;

$(document).ready(function () {
    $("#consultaionBtn").hide();
});

$('#calendar').datepicker({
    dateFormat: 'dd/mm/yy',
    inline: true,
    firstDay: 1,
    showOtherMonths: true,
    dayNamesMin: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],
    onSelect: function (dateText, inst) {
        
        dateSelected = dateText;
        $("#consultaionBtn").text("Planning de \n" + dateText);
        $("#consultaionBtn").show();
        alert("avant");
        getPlanning();
    }

})

function getPlanning() {
    alert("dans l'appel");
    alert(dateSelected);
    var dates = dateSelected;
    var url = "/Planning/getPlanning?selectedDate=" + dates; //getPlanningurl + dateSelected;
    $.get(url, function (data, status) {
        //alert("data : " + data + "\n status : " + status);
        window.location();
    })
}

//$("#consultaionBtn").click(function () {
//    $("#consultaionBtn").hide();
//    //alert(dateSelected);
//    //var dates = dateSelected;
//    //var url = "/Planning/getPlanning?selectedDate=" + dates; //getPlanningurl + dateSelected;
//    //$.get(url, function (data, status) {
//    //    //alert("data : " + data + "\n status : " + status);
//    //    window.location();
//    //})
//})

$('#enregistrerId').click(function () {
    
    var date;
    var promotion = escape($('#promotionId').val());
    var matiere = escape($('#matierId').val());
    var salle = escape($('#salleId').val());
    var professeur = escape($('#professeurId').val());
    var heuredabut = $('#heuredebutId').val();
    var heurefin = $('#heurefinId').val();
    if (promotion == null || matiere == null || salle == null || professeur == null || heuredabut == null || heurefin == null || promotion == "" || matiere == "" || salle == "" || professeur == "" || heuredabut == "" || heurefin == "") {
        alert("tous les champs sont obligatoire!");
    }
    else {
        var url = saveUrl; //+ promotion + "&matiere=" + matiere + "&salle=" + salle + "&professeur=" + professeur + "&heuredabut=" + heuredabut + "&heurefin=" + heurefin;
        $.post(url,
            {
                promotion: promotion,
                matiere: matiere,
                salle: salle,
                professeur: professeur,
                heuredabut: heuredabut,
                heurefin: heurefin
            },
            function (data, status) {
                alert("data: " + data + "\n status: " + status);
            })
    }
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