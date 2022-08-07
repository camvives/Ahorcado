// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

$(document).ready(function () {
    let ShowStatisticsBtn = document.getElementById("showStatistics");
    ShowStatisticsBtn.addEventListener("click", changeStatisticsVisibility, false);
});

function changeStatisticsVisibility() {
    let statistics = document.getElementsByClassName("estadisticas")[0];
    statistics.hidden = !statistics.hidden;
}