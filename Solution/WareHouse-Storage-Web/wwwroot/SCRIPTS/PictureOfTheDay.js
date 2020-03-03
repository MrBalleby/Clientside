$(document).ready(function () {
    $(function () {
        $('#button').on('click', function () {
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY",
                success: function (data) {
                    $('#MediaTitle').append(JSON.stringify(data.title));
                    $('#Date').append(JSON.stringify(data.date));
                    $('#Explanation').append(JSON.stringify(data.explanation));
                    $('#URL').append(JSON.stringify(data.url));
                    
                }
            });
        });
        
    });
});