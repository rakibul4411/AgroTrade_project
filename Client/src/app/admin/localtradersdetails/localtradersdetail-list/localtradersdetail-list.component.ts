import { Component, OnInit } from '@angular/core';
import { LocaltradersdetailService } from 'src/app/shared/localtradersdetail.service';
import { ToastrService } from 'ngx-toastr';
import { Localtradersdetail } from 'src/app/shared/localtradersdetail.model';

@Component({
  selector: 'app-localtradersdetail-list',
  templateUrl: './localtradersdetail-list.component.html',
  styleUrls: ['./localtradersdetail-list.component.css']
})
export class LocaltradersdetailListComponent implements OnInit {
  constructor(private service: LocaltradersdetailService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(ltd: Localtradersdetail) { 
    this.service.formData = Object.assign({}, ltd);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteLocalTradersDetails(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'ltd. Register');
      });
    }
  }

}
