$.get("getOrdenes", function (data) {
    Ordenes(data);
    console.log(data);
});


function Ordenes(data) {
    var contenido = '';

    contenido += '<table cellspacing="0" rules="all" border="1" id="tablaDatos" style="color:Black;background-color:#E9E9E9;border-color:black;border-collapse:collapse;text-align: center; margin-bottom: 10px;width:100%">';
    contenido += '<tr style="color: white;background-color:orange;border-color:white;height:40px;">';
    contenido += '<th># Orden</th>';
    contenido += '<th>Prioridad</th>';
    contenido += '<th># Maquina</th>';
    contenido += '<th>Comentario Inicial</th>';
    contenido += '<th>Area</th>';
    contenido += '<th>Causa</th>';
    contenido += '<th>Hora Inicio</th>';
    contenido += '<th>Hora I Atencion</th>';
    contenido += '<th>Hora F Atencion</th>';
    contenido += '<th>Hora I Liberación</th>';
    contenido += '<th>Tiempo muerto</th>';
    contenido += '<th>Personal</th>';
    contenido += '<th colspan="2">Estatus</th>';
    contenido += '</tr>';

    for (var i = 0; i < data.length; i++) {

        contenido += '<tr style="height:35px;">';
        contenido += '<td>'+data[i].IdOrden+'</td>';
        if (data[i].Prioridad === '1000') {
            contenido += '<td>Sin prioridad</td>';
        } else {
            contenido += '<td>'+data[i].Prioridad+'</td>';
        }
        contenido += '<td>'+data[i].Maquina+'</td>';
        contenido += '<td>'+data[i].ComentarioInicial+'</td>';
        contenido += '<td>'+data[i].Area+'</td>';
        contenido += '<td>'+data[i].Causa+'</td>';
        contenido += '<td>'+data[i].HoraInicio+'</td>';
        contenido += '<td>'+data[i].HoraInicioAtencion+'</td>';
        contenido += '<td>'+data[i].HoraFinalAtencion+'</td>';
        contenido += '<td>'+data[i].HoraInicioLiberacion+'</td>';
        contenido += '<td>'+data[i].TiempoMuerto+'</td>';
        contenido += '<td>' + data[i].Personal + '</td>';


        if (data[i].Estatus == "Cerrada") {
            contenido += "<td><img src='../Content/images/circles/verde.png'/></td>";
        }
        else if (data[i].Estatus == "Preventivo") {
            contenido += "<td><img src='../Content/images/circles/amarillo.png'/></td>";
        }
        else if (data[i].Estatus == "Paro" || data[i].Estatus == "Fallida") {
            contenido += "<td><img src='../Content/images/circles/rojo.png'/></td>";
        }
        else if (data[i].Estatus == "Servicio") {
            contenido += "<td><img src='../Content/images/circles/azul.png'/></td>";
        }
        else if (data[i].Estatus == "Liberación") {
            contenido += "<td><img src='../Content/images/circles/morado.png'/></td>";
        }

        contenido += '<td>'+data[i].Estatus+'</td>';
    }

    document.getElementById("tablaOrdenes").innerHTML = contenido;
}