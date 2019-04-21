import { Component, OnInit } from '@angular/core';
//import { ProductunitService } from 'src/app/admin/shared/productunit.service';
import { ToastrService } from 'ngx-toastr';
import { ProductunitService } from 'src/app/shared/productunit.service';
import { Productunit } from 'src/app/shared/productunit.model';
//import { Productunit } from 'src/app/admin/shared/productunit.model';

@Component({
  selector: 'app-productunit-list',
  templateUrl: './productunit-list.component.html',
  styleUrls: ['./productunit-list.component.css']
})
export class ProductunitListComponent implements OnInit {

  constructor(private service: ProductunitService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(pu: Productunit) { 
    this.service.formData = Object.assign({}, pu);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteProductUnit(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'PU. Register');
      });
    }
  }

}
