import { Component, OnInit } from '@angular/core';
import { WholesalerService } from 'src/app/shared/wholesaler.service';
import { ToastrService } from 'ngx-toastr';
import { Wholesaler } from 'src/app/shared/wholesaler.model';

@Component({
  selector: 'app-wholesaler-list',
  templateUrl: './wholesaler-list.component.html',
  styleUrls: ['./wholesaler-list.component.css']
})
export class WholesalerListComponent implements OnInit {

  constructor(private service: WholesalerService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(ws: Wholesaler) { 
    this.service.formData = Object.assign({}, ws);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteWholeSalers(id).subscribe(res => {
        this.toastr.warning('Deleted successfully', 'ws. Register');
        this.service.refreshList();
        
      });
    }
  }

}
