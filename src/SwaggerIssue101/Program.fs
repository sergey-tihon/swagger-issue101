open SwaggerProvider

[<Literal>]
let schema = @"https://eaccountingapi-sandbox.test.vismaonline.com/swagger/docs/v2"

type VismaApi = SwaggerProvider<schema>
let api = VismaApi.Client()


let [<Literal>]schema2 = "http://petstore.swagger.io/v2/swagger.json"
type PetStore = SwaggerProvider<schema2, PreferAsync=true> // Provided Types
let petStore = PetStore.Client()


[<EntryPoint>]
let main argv =
    let customers = petStore.GetPetById(101L)
    0
