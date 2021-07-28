function ValidarFechas(fechaInicio, fechaFin) {
    let dateIni = new Date(fechaInicio);
    let dateFin = new Date(fechaFin);

    if (dateFin > dateIni) {
        return false;
    } else { return true; }
}

function LoadingOverlayShow(id) {
    $(id).LoadingOverlay("show", {
        color: "rgb(255, 255, 255, 0,5)",
        image: "/Img/loading.gif",
        imageResizeFactor: 0.6
        //imageAnimation: "1.5s fadein"

    });
}

function LoadingOverlayHide(id) {
    $(id).LoadingOverlay("hide");
}