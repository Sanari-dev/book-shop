var dataTable;

$(document).ready(function () {
    LoadDataTable();
});


function LoadDataTable() {
    dataTable = $('#tableData').DataTable({
        "ajax": { url: '/admin/company/getall' },
        "columns": [
            { data: 'name', "width": "15%" },
            { data: 'streetAddress', "width": "15%" },
            { data: 'city', "width": "10%" },
            { data: 'state', "width": "15%" },
            { data: 'postalCode', "width": "10%" },
            { data: 'phoneNumber', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group"> 
                        <a href="company/upsert?id=${data}" class="btn btn-success mx-2"> <i class="bi bi-pencil-square"> </i> Edit </a>
                        <a onClick=Delete('company/delete?id=${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"> </i> Delete </a>
                    </div>`
                },
                "width": "22%"
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    });
}
