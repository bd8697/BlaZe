window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "!!!");
    }

    if (type === "error") {
        toastr.error(message, "???");
    }
}

function ShowConfirmDelete() {
    $('#deleteConfirmationModal').modal('show');
}

function HideConfirmDelete() {
    $('#deleteConfirmationModal').modal('hide');
}