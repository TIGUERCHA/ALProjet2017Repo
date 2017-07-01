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

$("#searchId").click(function () {
    alert("ok");
    //var searchSansCri = "&btnumero=&articlecode=&techniciencode=&startbesoindate=&finishbesoindate=&ticketremedy=&usercreation=&iginterventioncode=&natureBt=&equipeBt=&mesDemandes=false&codemagasinautre=&codemagasinorigine=&codeigLivraison=&client=0&operateur=";
    //var searchString = GetValueSearch();
    ////alert(GetValueSearch(searchString));
    //if (searchString == searchSansCri + "and" || searchString == searchSansCri + "or")
    //    $('#modalRechercheSansCritere').modal('show');
    //else
    //    search();
});