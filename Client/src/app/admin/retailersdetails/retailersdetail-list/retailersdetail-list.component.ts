import { Component, OnInit } from '@angular/core';
import { RetailersdetailService } from 'src/app/shared/retailersdetail.service';
import { ToastrService } from 'ngx-toastr';
import { Retailersdetail } from 'src/app/shared/retailersdetail.model';

@Component({
  selector: 'app-retailersdetail-list',
  templateUrl: './retailersdetail-list.component.html',
  styleUrls: ['./retailersdetail-list.component.css']
})
export class RetailersdetailListComponent implements OnInit {
	
 constructor(private service: RetailersdetailService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(rd: Retailersdetail) { 
    this.service.formData = Object.assign({}, rd);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteRetailersDetails(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'rd. Register');
      });
    }
  }

}
