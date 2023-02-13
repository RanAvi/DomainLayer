using DomainLayer.Manager.Enums;
using DomainLayer.Manager.Model;
using DomainLayer.Manager.ServiceLocators;
using DomainLayer.Manager.Services.ImdbService;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Manager {
    internal sealed class MovieManager:IDisposable {

        private bool _disposed;
        private ImdbServiceGateway _imdbServiceGateway;
        private readonly ServiceLocatorBase _serviceLocator;

        private ImdbServiceGateway ImdbServiceGateway{get {  return _imdbServiceGateway ?? (_imdbServiceGateway = _serviceLocator.CreateImdbServiceGateway()); } }

        public MovieManager(ServiceLocatorBase serviceLocator) {
            _serviceLocator = serviceLocator;
        }

        internal Task<int> CreateMovie(Movie movie) {
            throw new NotImplementedException();
        }

        internal Task<IEnumerable<Movie>> GetMoviesByGenre(Genre genre) {
            throw new NotImplementedException();
        }

        internal Task<Movie> GetMovieById(int id) {
            throw new NotImplementedException();
        }

        internal Task<IEnumerable<Movie>> GetAllMovies() {
            throw new NotImplementedException();
        }

        [ExcludeFromCodeCoverage]
        private void Dispose(bool disposing) {
            if (disposing && !_disposed && _imdbServiceGateway != null)
            {
                var localImdbServiceGateway = _imdbServiceGateway;
                localImdbServiceGateway.Dispose();
                _imdbServiceGateway = null;
                _disposed = true;
            }
        }

        public void Dispose() {
            Dispose(true);
        }
    }
}
