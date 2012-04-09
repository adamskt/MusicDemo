

var ViewModel = function () {
    var self = this;

    self.ArtistId = 0;
    self.GenreId = 0;

    self.Title = ko.observable("");
    self.Artist = ko.observable("");
    self.Price = ko.observable(0);
    self.DisplayPrice = ko.computed(function () {
        return "$" + self.Price();
    });
    self.AlbumArtUrl = ko.observable("");
    self.ErrorMessage = ko.observable("");
    self.SuccessMessage = ko.observable("");

    self.makeModel = function () {
        return {
            "AlbumArtUrl":self.AlbumArtUrl,
            "AlbumId": albumId,
            "Price":self.Price,
            "Title": self.Title,
            "ArtistId": self.ArtistId,
            "GenreId": self.GenreId
        };

    }

    self.load = function (album) {
        self.ArtistId = album.ArtistId;
        self.GenreId = album.GenreId;
        self.Title(album.Title);
        self.Artist(album.Artist.Name);
        self.Price(album.Price);
        self.AlbumArtUrl(album.AlbumArtUrl);
    };

    self.Save = function () {
        var request = $.ajax({
            type: "PUT",
            url: "/api/albums/" + albumId,
            data: self.makeModel()
        });
           
        request.success(function () {
            self.SuccessMessage("Save successfull!");            
        });

        request.fail(function (jqXHR) {
            self.ErrorMessage(jqXHR.responseText);
        });

    };
};


$(function () {

    $("#editor").hide();

    $("#editLink").click(function () {
        $("#editor").toggle('slow');
    });

    var viewModel = new ViewModel();

    $.get("/api/albums/" + albumId, function (data) {
        viewModel.load(data);
    });

    ko.applyBindings(viewModel);
});