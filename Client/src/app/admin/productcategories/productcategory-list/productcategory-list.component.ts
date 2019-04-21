import { Component, OnInit } from '@angular/core';
//import { ProductcategoryService } from 'src/app/admin/shared/productcategory.service';
//import { Productcategory } from 'src/app/admin/shared/productcategory.model';
import { ToastrService } from 'ngx-toastr';
import { ProductcategoryService } from 'src/app/shared/productcategory.service';
import { Productcategory } from 'src/app/shared/productcategory.model';

@Component({
  selector: 'app-productcategory-list',
  templateUrl: './productcategory-list.component.html',
  styleUrls: ['./productcategory-list.component.css']
})
export class ProductcategoryListComponent implements OnInit {

  constructor(private service: ProductcategoryService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(pcn: Productcategory) { 
    this.service.formData = Object.assign({}, pcn);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteProductCategory(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'PCN. Register');
      });
    }
  }

}
