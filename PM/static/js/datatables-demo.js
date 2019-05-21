// Call the dataTables jQuery plugin
$(document).ready(function() {
    $('#dataTable').DataTable({
        "language": {
                "info": "Pagina _PAGE_ de _PAGES_ pagina(as)",
                "lengthMenu": "Mostre _MENU_ por pagina",
                "search": "Busca",
            "paginate": {
                "previous": "Anterior",
                "next": "Proximo"
            }
                
        }
    });
});
