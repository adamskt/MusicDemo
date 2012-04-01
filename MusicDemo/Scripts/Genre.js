var GenreViewModel = function () {
    var _genre, self = this;
    
    $.ajax({
        url: "/api/genres/" + GenreId,
        async: false,
        success: function (data) { _genre = data }
    });

    self.Genre = ko.observable(_genre);
    self.Albums = ko.observableArray();

    self.load = function (data, property) {
        ko.utils.arrayForEach(data, function (item) {
            property.push(item);
        });
    };
};

$(function () {

    var viewModel = new GenreViewModel();

    $.get("/api/albumsbygenre/" + GenreId, function (data) {
        viewModel.load(data, viewModel.Albums);
    });

    ko.applyBindings(viewModel);
});