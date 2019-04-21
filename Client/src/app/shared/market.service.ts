import { Injectable } from '@angular/core';
import { Market } from './market';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MarketService {

  formData  : Market;
  list : Market[];
 readonly rootURL ="http://localhost:54277/api"
 
 constructor(private http : HttpClient) { }

 postMarketList(formData : Market){
   console.log(formData);
  return this.http.post(this.rootURL+'/MarketList',formData);
  }

  refreshList(){
    this.http.get(this.rootURL + '/MarketList')
    .toPromise().then(res => this.list = res as Market[]);
  }
  putMarketList(formData : Market){
    return this.http.put(this.rootURL+'/MarketList/'+ formData.Market_ID,formData);
    }

    deleteMarketList(id : number){
      return this.http.delete(this.rootURL+'/MarketList/'+id);
     }

}
