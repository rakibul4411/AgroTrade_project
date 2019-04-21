import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Localproductsource } from './localproductsource.model';

@Injectable({
  providedIn: 'root'
})
export class LocalproductsourceService {

  formData  : Localproductsource;
  list : Localproductsource[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postLocalProductSource(formData : Localproductsource){
   console.log(formData);
  return this.http.post(this.rootURL+'/LocalProductSource',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/LocalProductSource')
    .toPromise().then(res => this.list = res as Localproductsource[]);
  }
  putLocalProductSource(formData : Localproductsource){
    return this.http.put(this.rootURL+'/LocalProductSource/'+ formData.Local_Product_Source_ID,formData);
    }

    deleteLocalProductSource(id : number){
      return this.http.delete(this.rootURL+'/LocalProductSource/'+ id);
     }

}
