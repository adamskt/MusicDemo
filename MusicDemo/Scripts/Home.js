var ViewModel = function () {
    // Rookie mistake #1, "this" changes scope inside delegates, so solidify it here
    var self = this;

    self.FirstName = ko.observable("");
    self.LastName = ko.observable("");

    self.Greeting = ko.computed(function () {
        if (self.LastName().length > 0 && self.FirstName().length > 0) {
            return "Hello, " + self.FirstName() + " " + self.LastName() + "!";
        }
    });

    self.Genres = ko.observableArray();


    self.load = function (data, property) {
        ko.utils.arrayForEach(data, function (item) {
            property.push(item);
        });
    };
}

$(function () {

    var viewModel = new ViewModel();

    $.get("/api/genres", function (data) {
        viewModel.load(data, viewModel.Genres);
    });


    // Rookie mistake #2, it's easy to forget to tell KO to set up the databindings
    ko.applyBindings(viewModel);
});