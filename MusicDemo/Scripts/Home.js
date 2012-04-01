var GenreListViewModel = function () {
    var self = this;
    self.Genres = ko.observableArray();

    self.load = function (data, property) {
        ko.utils.arrayForEach(data, function (item) {
            property.push(item);
        });
    };
}

$(function () {

    var viewModel = new GenreListViewModel();

    $.get("/api/genres", function (data) {
        viewModel.load(data, viewModel.Genres);
    });

    ko.applyBindings(viewModel);
});