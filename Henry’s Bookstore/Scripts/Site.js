$(document).ready(function () {
    function ajaxValidate() {
        return $('#form0').validate().form();
    }
    $("#form0").validate({
        rules: {
            // simple rule, converted to {required:true}
            FirstName: "required",
            LastName: "required",
            // compound rule
            EmailAddress: {
                required: true,
                email: true
            },
            ConfirmEmailAddress: {
                required: true,
                email: true
            },
            BranchNumber: {
                required: true,
            },
            Comments: "required",
        },
        rules: {
            EmailAddress: "required",
            ConfirmEmailAddress: {
                equalTo: "#EmailAddress"
            },
            messages: {
                FirstName: "Please specify your name",
                LastName: "Please specify your name",
                EmailAddress: {
                    required: "We need your email address to contact you",
                    EmailAddress: "Your email address must be in the format of name@domain.com"
                },
                ConfirmEmailAddress: {
                    required: "We need your email address to contact you",
                    EmailAddress: "Your email address must be in the format of name@domain.com"
                },
                Comments: "Please enter your comment"
            }
        }
    })
});
