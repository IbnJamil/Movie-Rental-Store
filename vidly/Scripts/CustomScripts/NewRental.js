window.onload=ready;
function ready() {

    var vm = { movieId: [] };
    var customers = new Bloodhound({
        datumTokenizer: Bloodhound.tokenizers.obj.whitespace('customersName'),
        queryTokenizer: Bloodhound.tokenizers.whitespace,
        remote: {
            url: '../api/customer?queries=%QUERY',
            wildcard: '%QUERY'
        }
    });

    $('#customer').typeahead({
        minLength: 1,
        highlight: true
    }, {
        name: 'customers',
        display: 'customersName',
        source: customers
    }).on("typeahead:select", function (e, customers) {
        vm.customerId = customers.id;
    });
    $.validator.addMethod("validCustomer", function () {
        return vm.customerId && vm.customerId != null
    }, "Select a Valid customer");

    ///////////////////////////////........Movie....../////////////////////////////////////////////////////////////
    var movies = new Bloodhound({
        datumTokenizer: Bloodhound.tokenizers.obj.whitespace('moviesName'),
        queryTokenizer: Bloodhound.tokenizers.whitespace,
        remote: {
            url: '../api/movie?queries=%QUERY',
            wildcard: '%QUERY'
        }
    });

      $('#movie').typeahead({
        minLength: 1,
        highlight: true
    },
     {
         name: 'movies',
         display: 'moviesName',
         source: movies
     })
         .on("typeahead:select", function (e, movies) {
             $("#movie").typeahead("val", "");
             $("#movies").append("<li class='list-group-item'>" + movies.moviesName + "</li>");
             vm.movieId.push(movies.id);
         });

    $.validator.addMethod("validMovie", function () {
        return vm.movieId.length > 0
    }, "Select a Valid movie");

    //////////////////////////////......form.........//////////////////////////////////////////////////////////////
    var validator = $("#form").validate({
        submitHandler: function () {

            $.ajax({
                url: "/api/NewRental",
                method: "POST",
                data: vm,
                success: function (data) {
                    toastr.success("Posted SucessFully");
                    $("#movie").typeahead("val", "");
                    $("#customer").typeahead("val", "");
                    vm = { movieId: [] };
                    $("#movies").empty();
                    validator.resetForm();
                },

                error: function (err) {
                    toastr.error("Some Thing Went Wrong");
                }
            });
            return false;
        }
    })
};