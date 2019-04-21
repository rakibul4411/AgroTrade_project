import { Component, OnInit } from '@angular/core';
import { TraderslistService } from 'src/app/shared/traderslist.service';
import { ToastrService } from 'ngx-toastr';
import { Traderslist } from 'src/app/shared/traderslist.model';

@Component({
  selector: 'app-traderslist-list',
  templateUrl: './traderslist-list.component.html',
  styleUrls: ['./traderslist-list.component.css']
})
export class TraderslistListComponent implements OnInit {

 
  constructor(private service: TraderslistService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(tl: Traderslist) { 
    this.service.formData = Object.assign({}, tl);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteTradersList(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'TL. Register');
      });
    }
  }

}
