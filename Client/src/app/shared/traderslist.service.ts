import { Injectable } from '@angular/core';
import { Traderslist } from './traderslist.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TraderslistService {

  formData  : Traderslist;
  list : Traderslist[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postTradersList(formData : Traderslist){
   console.log(formData);
  return this.http.post(this.rootURL+'/TradersList',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/TradersList')
    .toPromise().then(res => this.list = res as Traderslist[]);
  }
  putTradersList(formData : Traderslist){
    return this.http.put(this.rootURL+'/TradersList/'+ formData.Trader_ID,formData);
    }

    deleteTradersList(id : number){
      return this.http.delete(this.rootURL+'/TradersList/'+id);
     }

}
