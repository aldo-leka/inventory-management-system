function preventFormSubmission(formId) {
    document.getElementById(`${formId}`).addEventListener('keydown', function (event) {
        if (event.key === "Enter") {
            console.log("why not working?");
            event.preventDefault();
            return false;
        }
    });
}