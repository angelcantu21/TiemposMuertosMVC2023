
$.get("getMaquinas", function (data) {
    Maquinas(data);
    console.log(data);
});


function Maquinas(data) {
    var contenido = '';
    var color = '', icono = '', area = '', linea = '';
    var contador = 0;

    for (var i = 0; i < data.length; i++) {

        if (data[i].Estatus == true) {
            color = "btn-success";
        } else {
            color = "btn-dark";
        }

        if (data[i].Reporte == "AP") {
            color = "btn-warning";
        } else if (data[i].Reporte == "TM") {
            color = "btn-danger";
        }
        else if (data[i].Reporte == "SERVICIO AP" || data[i].Reporte == "SERVICIO TM") {
            color = "btn-primary";
        }
        else if (data[i].Reporte == "LIBERACIÓN AP" || data[i].Reporte == "LIBERACIÓN TM") {
            color = "btn-purple";
        }

        if (area != data[i].Zona) {
            if (contador > 0) {
                contenido += "</div>" +
                    "</fieldset>";
            }
            contenido += "<div class='legend1'>"+data[i].Zona+"</div>" +
                "<fieldset class='fieldset-maquinas'>" +
                "<div class='form-row' style='margin: auto;'>";
        }

        contenido += '<div class="col-auto a" style="margin:5px;padding:5px;"><a onclick="abrirModal(' + "'" + data[i].Reporte + "'" + ',' + data[i].Estatus + ');" class="btn ' + color + ' mb-2" style="padding: 30px 70px;margin:3px 10px;"><span>' + data[i].Nombre + '</span><br /><br /><span class="icono"><i class="' + data[i].Icono + '"></i></span></a></div>';
        area = data[i].Zona;
        contador++;
    }


    document.getElementById("maquinas").innerHTML = contenido;
}

function abrirModal(reporte, status) {

    if (status === false) {
        return;
    }

    if (reporte != '-') {
        $('#atenderModal').modal('show');
    } else {
        $('#seleccionModal').modal('show');
    }
}