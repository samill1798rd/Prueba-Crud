
var oTableClientes = {};


$(document).ready(function () {
    $('#dataTables-example').dataTable();
  
});


$(document).on('click', '.btnDelete', function (data) {
    debugger
    let idCliente = $(this).attr('data-delete-id');

    alert(`El id de cliente es ${idCliente}`);
})

//function CargarTablaClientes() {
//    debugger
//    oTableClientes = $('#dataTables-example').dataTable({
//        paging: true
//        , ordering: true
//        , searching: true
//        , Processing: true,
//        serverSide: true,
//        ajax: {
//            url: window.getClientes
//            , type: 'POST'
//            //, data: data
//                //function (d) {
//            //    d.UnidadCodigo = unidadCodigo;
//            //}
//        }
//        data: data
//        , columns: [
//            { sTitle: "Id", visible: false }
//            , { sTitle: 'Nombre', }
//            , { sTitle: "Apellido" }
//            , { sTitle: "Cedula" }
//            , {
//                sTitle: "Eliminar",
//                mData: [0], bSearchable: false, bSortable: false, class: 'center',
//                "mRender": function (data) {
//                    var button = '<a class="btn btn-danger btn-eliminar-Usuario" id="btnEliminar" data-id="' +
//                        data +
//                        '" href="javascript:;">' +
//                        '<i class="fa fa-trash-o"></i></a>';
//                    return button;
//                }
//            }

//        ]
//        , lengthMenu: [[5, 10, 25, 50], [5, 10, 25, 50]]
//        , DisplayLength: 5
//    });
//}




  
