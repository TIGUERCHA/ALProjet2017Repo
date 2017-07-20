$(document).ready(function () {
    //$('#formulaire').show();
    //$('#formulaire2').show();
    initview();
});

function initview() {

    $("#consultaionBtn").hide();

    var url = "/Connexion/GetInfoUser";
    $.getJSON(url, null, function (json) {
        console.log(json);
        if (json.email === "") {
            $('#navPlanningId').hide();
            $('#logOutLink').hide();
            $('#loginLink').show();
        } else {
            $('#navPlanningId').show();
            $('#logOutLink').show();
            $('#loginLink').hide();
        }
        if (json.status === "ADMIN") {
            $('#formulaire').show();
            $('#formulaire2').show();
        } else {
            $('#formulaire').hide();
            $('#formulaire2').hide();
        }

    });
}

$('#ConnexionBtnId').click(function () {

    var email = $('#ConnexionEmailId').val();
    var pwd = $('#ConnexionPasswordId').val();
    var url = CheckLoginUrl;

    $.post(url,
        {
            email : email,
            password : pwd
        }, function (data, status) {
            if (status == "success") {
                if (data == "ADMIN") {
                    
                    $('#navAccueilId a')[0].click();
                    $('#navPlanningId').show();
                } else {
                    if (data == "ETUDIANT") {
                        
                        $('#navAccueilId a')[0].click();
                        $("#navPlanningId").show();
                    } else {
                        $("#idPopupMessage").val("E_mail ou Mot de passe incorrecte !");
                        $('#poPupMessage').modal('show');
                        $('#poPupMessage').css('zIndex', 10000);
                    }
                }
            } else {
            }
        });
})