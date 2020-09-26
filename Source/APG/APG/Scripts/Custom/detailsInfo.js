$(document).ready(function () {
    //$("#btnSubmit").hide();
    //$('.datepicker').datepicker({
    //    format: 'mm/dd/yyyy'
    //});

    $('#btnSubmit').click(function () {

        if (IsValid()) {
            var details = {};

            details.Id = 0; // $('#Id').val();
            details.FirstName = $('#FirstName').val();
            details.Address = $('#Address').val();
            details.HaveAlliance = $("input[name='HaveAlliance']:checked").val();
            details.HavePrescriptions = $("input[name='HavePrescriptions']:checked").val();

            //if ($('#HaveAlliance').prop("checked") == false) {
                $.ajax({
                    url: 'Home/Details',
                    type: "post",
                    dataType: "json",
                    data: details,
                    success: function (response, textStatus, jqXHR) {
                        alert(response.val);
                        $("#btnSubmit").attr("disabled", "disabled");
                        //window.location.href = '@Url.Action("Checkout", "Order")';
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        alert('Error - ' + errorThrown);
                        //alert("Some information is missing, please complete the entire form to continue..");
                    }
                });
            //}
            //else {
            //    alert("Please fill the form correctly with all information..")
            //}
        }
    });

});


function IsValid() {

    if ($('#FirstName').val() == '') {
        alert("Please provide your First Name")
        return false;
    }
    if ($('#Address').val() == '') {
        alert("Please provide the Email Address or Phone")
        return false;
    }

    //if ($('#HaveAlliance').prop("checked") == true) {
    //    if (addLeague.length < 1) {
    //        alert("Please fill the Club House League information.")
    //        return false;
    //    }
    //}

    return true;
}