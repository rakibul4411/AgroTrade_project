import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/shared/product.service';
import { ToastrService } from 'ngx-toastr';
import { Product } from 'src/app/shared/product.model';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  constructor(private service: ProductService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(p: Product) { 
    this.service.formData = Object.assign({}, p);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteProducts(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'P. Register');
      });
    }
  }

}

