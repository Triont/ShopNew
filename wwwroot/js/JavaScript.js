function ajaxfunc() {
    var data_ch = [];
    $("input:checkbox[name=type]:checked").each(function () {
        data_ch.push($(this).val());
    });
    $.ajax({
        type: "GET",
        url: '/Admin/GetJson',
        data: { Id: JSON.stringify(data_ch) },

        success: function (response) {


            var q_tb = document.getElementById("refresh");
            for (var i_q = 0; i_q < q_tb.rows.length; i_q++) {
                for (var j_q = 0; j_q < q_tb.rows[i_q].cells.length - 1; j_q++) {
                    switch (j_q) {
                        case 0:
                            q_tb.rows[i_q].cells[j_q].innerHTML = response.id[i_q];
                            break;
                        case 1:
                            q_tb.rows[i_q].cells[j_q].innerHTML = response.name[i_q];
                            break;
                        case 2:
                            q_tb.rows[i_q].cells[j_q].innerHTML = response.secondname[i_q];
                            break;

                        case 3:
                            q_tb.rows[i_q].cells[j_q].innerHTML = response.phone[i_q];
                            break;
                        case 4:
                            q_tb.rows[i_q].cells[j_q].innerHTML = response.email[i_q];
                            break;
                        case 5:
                            q_tb.rows[i_q].cells[j_q].innerHTML = response.totalprice[i_q];
                            break;
                        case 6:
                            q_tb.rows[i_q].cells[j_q].innerHTML = response.status[i_q];
                            break;
                        case 7:
                            q_tb.rows[i_q].cells[j_q].innerHTML = response.createdatetime[i_q];
                            break;

                    }


                }
            }
        }
    });
}
        