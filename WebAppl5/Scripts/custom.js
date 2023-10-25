$(document).ready(function () {
    // This function runs when the document is ready

    // Attach an event handler to the form submission
    $("form").on("submit", function (event) {
        // Prevent the default form submission
        event.preventDefault();

        // Get the SQL query from the input field
        var sqlQuery = $("#SqlQuery").val();

        // You can add more custom code here to process the query

        // Example: Show an alert with the SQL query
        alert("SQL Query: " + sqlQuery);
    });
});
