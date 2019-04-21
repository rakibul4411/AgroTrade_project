import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Importedproductsource } from './importedproductsource.model';


@Injectable({
  providedIn: 'root'
})
export class ImportedproductsourceService {

  formData  : Importedproductsource;
  list : Importedproductsource[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postImportedProductSource(formData : Importedproductsource){
   console.log(formData);
  return this.http.post(this.rootURL+'/ImportedProductSource',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/ImportedProductSource')
    .toPromise().then(res => this.list = res as Importedproductsource[]);
  }
  putImportedProductSource(formData : Importedproductsource){
    return this.http.put(this.rootURL+'/ImportedProductSource/'+ formData.Imported_Product_Source_ID,formData);
    }

    deleteImportedProductSource(id : number){
      return this.http.delete(this.rootURL+'/ImportedProductSource/'+id);
     }

}
