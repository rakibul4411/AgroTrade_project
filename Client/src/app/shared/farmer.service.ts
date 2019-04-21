import { Injectable } from '@angular/core';
import { Farmer } from './farmer.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FarmerService {
//new from employee

  formData  : Farmer;
  list : Farmer[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postFarmerList(formData : Farmer){
   console.log(formData);
  return this.http.post(this.rootURL+'/FarmerList',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/FarmerList')
    .toPromise().then(res => this.list = res as Farmer[]);
  }
  putFarmerList(formData : Farmer){
    return this.http.put(this.rootURL+'/FarmerList/'+ formData.Farmer_ID,formData);
    }

    deleteFarmerList(id : number){
      return this.http.delete(this.rootURL+'/FarmerList/'+id);
     }

}
