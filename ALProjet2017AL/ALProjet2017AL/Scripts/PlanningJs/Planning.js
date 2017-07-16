var dateSelected = null;

$(document).ready(function () {
    initview();
});

$('#calendar').datepicker({
    dateFormat: 'dd/mm/yy',
    inline: true,
    firstDay: 1,
    showOtherMonths: true,
    dayNamesMin: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],
    onSelect: function (dateText, inst) {
        dateSelected = dateText;
        getPlanning();
        alert("alert");
        $('#consultaionBtn').focus().click();
    }

})

function initview() {
    
    $("#consultaionBtn").hide();
}

function getPlanning() {
    var dates = dateSelected;
    var url = "/Planning/getPlanning?selectedDate=" + dates; //getPlanningurl + dateSelected;
    $.get(url, function (data, status) {
        //alert("data : " + data + "\n status : " + status);
        window.location();
    })
}

//$("#consultaionBtn").click(function () {
//    //$('#consultaionBtn').load(_ConsultationPlanning.cshtml, function(responseTxt, statusTxt, xhr){
//    //    if(statusTxt == "success")
//    //        alert("External content loaded successfully!");
//    //    if(statusTxt == "error")
//    //        alert("Error: " + xhr.status + ": " + xhr.statusText);
//    //});

//    //$("#consultaionBtn").hide();
//    //alert(dateSelected);
//    //var dates = dateSelected;
//    //var url = "/Planning/getPlanning?selectedDate=" + dates; //getPlanningurl + dateSelected;
//    //$.get(url, function (data, status) {
//    //    alert("data : " + data + "\n status : " + status);
//    //    window.location();
//});

//    $.ajax({
//        url: '/Planning/getPlanning?selectedDate=' + dates,
//        cache: false
//    }).done(function (data) {
//        // cette fonction est appelée lorsque nous avons des données
//        // TODO : mettre à jour le contenu
//    });
//})

$('#enregistrerId').click(function () {
    
    var date = $('#dateId').val();
    var promotion = $('#promotionId').val();
    var matiere = escape($('#matierId').val());
    var salle = escape($('#salleId').val());
    var professeur = escape($('#professeurId').val());
    var heuredabut = $('#heuredebutId').val();
    var heurefin = $('#heurefinId').val();
    if (promotion == null || matiere == null || salle == null || professeur == null || heuredabut == null || heurefin == null || date == null || promotion == "" || matiere == "" || salle == "" || professeur == "" || heuredabut == "" || heurefin == "" || date == "") {
        $("#idPopupMessage").val("Veuillez renseigner tous les champs !");
        $('#poPupMessage').modal('show');
        $('#poPupMessage').css('zIndex', 10000);
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
                heurefin: heurefin,
                date: date
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