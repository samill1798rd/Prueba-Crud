
$(document).ready(function () {
    debugger
    GetBalance();
    $('#tListaDeServicios').DataTable();
});


$(document).on('click', '.services', function (data) {
    debugger
    let codigousuario = $(this).attr('data-id');


    GetModalById(codigousuario)

    

})

function GetModalById(codigo) {

    $.ajax({
        url: "/PagosServicios/GetServicoById",
        type: "POST",
        data: { id: codigo },
        //dataType: "json",
        success: function (objResult) {
            debugger
            //MensajeQuitarBloqueo();
            $("#ListaServicios").html(objResult);
            //$.validator.unobtrusive.parse("#frmRegistrarCarta");
            //$("#datosConsulta").hide('slow');
            //$("#dvHogarResultado").show('slow');
            $('#VentanaModal').modal('toggle');

        }, error: function (objResult) {
            debugger
            //$codigoCentros.append(optionDefaults);

        }

    });
}


function GetBalance() {

    $.ajax({
        url: "/PagosServicios/GetBalance",
        type: "POST",
        //data: { id: codigo },
        dataType: "json",
        success: function (objResult) {
            debugger;
            $('#balance').text(objResult)

        }, error: function (objResult) {
            debugger
            //$codigoCentros.append(optionDefaults);

        }

    });
}
