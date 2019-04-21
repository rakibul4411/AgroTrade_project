import { Component, OnInit } from '@angular/core';
import { ImportedproductsourceService } from 'src/app/shared/importedproductsource.service';
import { ToastrService } from 'ngx-toastr';
import { Importedproductsource } from 'src/app/shared/importedproductsource.model';

@Component({
  selector: 'app-importedproductsource-list',
  templateUrl: './importedproductsource-list.component.html',
  styleUrls: ['./importedproductsource-list.component.css']
})
export class ImportedproductsourceListComponent implements OnInit {

  
  constructor(private service: ImportedproductsourceService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(ips: Importedproductsource) { 
    this.service.formData = Object.assign({}, ips);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteImportedProductSource(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'IPS. Register');
      });
    }
  }

}