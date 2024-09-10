$(document).ready(function () {
    function sendData() {
        var soGioChoi = $('#gio').val(); 
        var giaLoaiGay = $('input[name="LoaiGay"]:checked').val(); 
        var themDoa = $('#doa').is(':checked') ? $('#doa').val() : 0;
        if (isNaN(soGioChoi) || soGioChoi <= 0) {
            alert('Vui lòng nhập số giờ chơi hợp lệ.');
            return;
        }
        if (!giaLoaiGay) {
            alert('Vui lòng chọn loại gậy.');
            return;
        }

        var dataToSend = {
            gay: giaLoaiGay,
            gio: soGioChoi, 
            doa: themDoa,
        };

        $.ajax({
            url: "WebForm1.aspx",
            type: "POST",
            data: JSON.stringify(dataToSend),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                alert('Tổng thiệt hại là: ' + response);
            },
            error: function (xhr, status, error) {
                alert('Có lỗi xảy ra: ' + xhr.responseText);
            }
        });
    }

    $("#tinhtien").click(function () {
        sendData();
    });
});
