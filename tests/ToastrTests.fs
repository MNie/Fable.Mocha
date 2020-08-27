module ToastrTests

open Elmish
open Elmish.Toastr

let private toast level (title: string, message: string) =
    Toastr.message message
    |> Toastr.title title
    |> Toastr.position TopLeft
    |> level

let private showError m = toast Toastr.error m

let returnTrue =
    showError ("dd", "ded") |> ignore
    true