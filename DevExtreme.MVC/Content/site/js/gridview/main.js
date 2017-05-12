$(function () {


    $("#gridContainer").dxDataGrid({
        dataSource: "http://localhost/DevExtreme.MVC/GridView/Listar",
        paging: {
            pageSize: 10
        },
        showColumnLines: true,
        showRowLines: true,
        rowAlternationEnabled: true,
        showBorders: true,
        pager: {
            //showPageSizeSelector: true,
            //allowedPageSizes: [5, 10, 20],
            showInfo: true
        },
        //filterRow: {
        //    visible: true,
        //    applyFilter: "auto"
        //},
        searchPanel: {
            align: "left",
            visible: true,
            width: 240,
            placeholder: "Search..."
        },
        //headerFilter: {
        //    visible: true
        //},
        selection: {
            mode: "single"
        },
        //columnFixing: {
        //    enabled: true
        //},
        //columnChooser: {
        //    enabled: true
        //},
        allowColumnReordering: true,
        hoverStateEnabled: true,
        columns: [{
            dataField: "CompanyName",
            caption: "Company Name",
            fixed: false
        }, 
, {
            dataField: "Phone",
            fixed: false
        }, {
            dataField: "Fax",
            fixed: false
        }]
        //columns: ["CompanyName", "CompanyName", "City", "State", "Phone", "Fax"]
    });

});