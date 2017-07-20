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
        $('.divReservation').each(function (i, obj) {
    
            var date = $(this).data("date").split(" ")[0];
            if (date == dateSelected) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
        getPlanning();
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

$('#rechercherSalleId').click(function () {
    var date = $('#dateHomeId').val();
    var salle = $('#salleHomeId').val();
    var url = "/PlanningBySalle/Index?date=" + date + "&salle=" + salle; //getPlanningurl + dateSelected;
    $.get(url, function (data, status) {
        //alert("data : " + data + "\n status : " + status);
        window.location();
        var url = $("#RedirectTo").val();
        location.href = url;
    })
})

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
    var heuredebut = $('#heuredebutId').val();
    var heurefin = $('#heurefinId').val();
    if (promotion == null || matiere == null || salle == null || professeur == null || heuredebut == null || heurefin == null || date == null || promotion == "" || matiere == "" || salle == "" || professeur == "" || heuredebut == "" || heurefin == "" || date == "") {
        $("#idPopupMessage").val("Veuillez renseigner tous les champs !");
        $('#poPupMessage').modal('show');
        $('#poPupMessage').css('zIndex', 10000);
    }
    else {
        var url = saveUrl; //+ promotion + "&matiere=" + matiere + "&salle=" + salle + "&professeur=" + professeur + "&heuredebut=" + heuredebut + "&heurefin=" + heurefin;
        $.post(url,
            {
                promotion: promotion,
                matiere: matiere,
                salle: salle + '*' + heuredebut.toString() + '*' + heurefin.toString(),
                professeur: professeur,
                heuredebut: heuredebut,
                heurefin: heurefin,
                date: date
            },
            function (data, status) {
                $("#idPopupMessage").val("Status: " + status);
                $('#poPupMessage').modal('show');
                $('#poPupMessage').css('zIndex', 10000);
                
                $('input').val("");
                $('select').val("");

                var dateString = date.replace('-', '/').replace('-', '/');
                var dateString2 = dateString.split('/')[2] + '/'+ dateString.split('/')[1] + '/'+ dateString.split('/')[0];
                
                var html = '<div data-date="' + dateString2 + '" class="divReservation">'
                            + '<h5 class="modal-title" id="DemandeurLabel">' + dateString2 + '</h5>'
                            + '<h5 class="modal-title" id="entete3">'
                            + heuredebut
                            +'</h5>'
                            + '<ul>'
                                + '<li>'
                                    + promotion
                                + '</li>'
                                + '<li>'
                                    + matiere
                                + '</li>'
                                + '<li>'
                                    + salle
                                + '</li>'
                                + '<li>'
                                    + professeur
                                + '</li>'
                            + '</ul>'
                            + '<h5 class="modal-title" id="entete4">' + heurefin + '</h5>'
                            + '<hr />'
                        + '</div>';
                $('#consultaion .modal-body').append(html);
               
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

