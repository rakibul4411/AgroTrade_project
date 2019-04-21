import { Component, OnInit } from '@angular/core';
//import { MarketService } from '../../shared/market.service';
import { ToastrService } from 'ngx-toastr';
import { MarketService } from 'src/app/shared/market.service';
import { Market } from 'src/app/shared/market';
//import { Market } from '../../shared/market';

@Component({
  selector: 'app-market-list',
  templateUrl: './market-list.component.html',
  styleUrls: ['./market-list.component.css']
})
export class MarketListComponent implements OnInit {

  constructor(private service: MarketService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(mar: Market) { 
    this.service.formData = Object.assign({}, mar);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteMarketList(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'MAR. Register');
      });
    }
  }

}
